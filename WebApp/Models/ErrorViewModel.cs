using System;

namespace WebApp.Models
{
    public class ErrorViewModel
    {
        private int testInt;

        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}