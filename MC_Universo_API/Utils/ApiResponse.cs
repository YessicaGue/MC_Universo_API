﻿namespace MC_Universo_API.Utils
{
    public class ApiResponse<T>
    {
        public int StatusCode { get; set; }

        public bool Success { get; set; }

        public string Message { get; set; }

        public T? Data { get; set; }
    }
}
