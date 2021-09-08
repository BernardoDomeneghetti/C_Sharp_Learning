﻿using ByteBankLib.Models.Entities;
using ByteBankLib.Models.Enums;
using ByteBankLib.Models.Exceptions;
using ByteBankLib.Repository;

namespace ByteBankLib.Models.Response.CustomerResponses
{
    public class CustomerPromotionResponse:BaseResponse
    {
        public Customer PromotedCustomer { get; set; }

        public CustomerPromotionResponse(bool success)
        {
            if (success)
            {
                throw new CustomerResponseMisusedConstructorException("This constructor should be used only to failed operations");
            }
            Message = "Customer promotion failed";
            ErrorCode = ErrorCodeEnum.ServerError;
            PromotedCustomer = null;
        }

        public CustomerPromotionResponse(bool success, string message, ErrorCodeEnum errorCode, Customer promotedCustomer) : base(success, message, errorCode)
        {
            Success = success;
            Message = message;
            ErrorCode = errorCode;
            PromotedCustomer = promotedCustomer;

        }
        public CustomerPromotionResponse(bool success, string message, Customer promotedCustomer) : base(success, message)
        {
            Success = success;
            Message = message;
            if (success)
            {
                ErrorCode = ErrorCodeEnum.NothingToDo;
                PromotedCustomer = promotedCustomer;
            }
            else
            {
                ErrorCode = ErrorCodeEnum.ServerError;
                PromotedCustomer = null;
            }
            
        }
        public CustomerPromotionResponse(bool success, Customer promotedCustomer)
        {
            Success = success;
            if (success)
            {
                Message = "Customer promoted successfully";
                ErrorCode = ErrorCodeEnum.NothingToDo;
                PromotedCustomer = promotedCustomer;
            }
            else
            {
                Message = "Customer promotion failed";
                ErrorCode = ErrorCodeEnum.ServerError;
                PromotedCustomer = null;
            }
        }


    }
}
