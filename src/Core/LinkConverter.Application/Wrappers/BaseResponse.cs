using System;

namespace LinkConverter.Application.Wrappers
{
    public class BaseResponse
    {
        public string Message { get; set; }

        public bool IsSuccess { get; set; } = true;
    }
}