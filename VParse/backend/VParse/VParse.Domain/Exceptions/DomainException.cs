﻿namespace VParse.Domain.Exceptions;
 
public class DomainException(string message) : Exception(message)
{
}