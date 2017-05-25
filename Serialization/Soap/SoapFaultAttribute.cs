﻿using System;

namespace Softcore.Xml.Serialization.Soap
{
    /// <summary>
    /// This attribute is applied to a class property or field to specify a SOAP fault detail content. This class cannot be inherited.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public sealed class SoapFaultAttribute : SoapAttributeBase
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SoapFaultAttribute"/> class, setting a class' property representing the SOAP header content.
        /// </summary>
        public SoapFaultAttribute() : base()
        {
        }
    }
}