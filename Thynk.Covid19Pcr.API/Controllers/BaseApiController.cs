using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using Thynk.Covid19Pcr.Application.DTOs.Response;
using Thynk.Covid19Pcr.Domain.Enums;

namespace Thynk.Covid19Pcr.API.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class BaseApiController<T> : ControllerBase
    {
        private ILogger<T> _loggerInstance;
        protected ILogger<T> _logger => _loggerInstance ??= HttpContext.RequestServices.GetService<ILogger<T>>();

        protected IActionResult TransformResponse<U>(ExecutedResult<U> result)
        {
            string FailureMessage = "Request failed, please try again";

            try
            {
                switch (result.Response)
                {
                    case ResponseCode.AuthorizationError:
                        {
                            result.Message = result?.Message ?? FailureMessage;
                            return StatusCode(403, result);
                        }

                    case ResponseCode.ValidationError:
                    case ResponseCode.ProcessingError:
                        {
                            result.Message = result?.Message ?? FailureMessage;
                            return BadRequest(result);
                        }

                    case ResponseCode.NotFound:
                        {
                            result.Message = result?.Message ?? FailureMessage;
                            return NotFound(result);
                        }

                    case ResponseCode.Exception:
                        {
                            result.Message = result?.Message ?? FailureMessage;
                            return StatusCode(500, result);
                        }

                    case ResponseCode.Success:
                        {
                            result.Message = result?.Message ?? "Request was successful";
                            return Ok(result);
                        }

                    default:
                        {
                            result.Message = result?.Message ?? FailureMessage;
                            return BadRequest(result);
                        }
                }
            }
            catch (Exception)
            {
                return BadRequest(result);
            }
        }
    }
}
