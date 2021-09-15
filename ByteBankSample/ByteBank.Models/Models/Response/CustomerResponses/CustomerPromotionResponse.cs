﻿using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerPromotionResponse:CustomerResponse
    {
        public CustomerPromotionResponse(bool success, string message, ErrorCodeEnum errorCode, Customer customer) : base(success, message, errorCode, customer)
        {
        }
    }
}
