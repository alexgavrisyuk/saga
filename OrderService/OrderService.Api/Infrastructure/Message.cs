﻿namespace OrderService.Api.Infrastructure
{
    public class Message
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public string Data { get; set; }
    }
}