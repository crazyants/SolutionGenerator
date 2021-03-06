﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="DataApplicationTemplateContext.cs" company="WildGums">
//   Copyright (c) 2012 - 2016 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace SolutionGenerator.Templates.DataApplication
{

    public class DataApplicationTemplateContext : TemplateContextBase
    {
        public DataApplicationTemplateContext()
        {
            Company.Name = "MyCompanyName";

            Solution.Name = "MySolutionName";

			Data = new DataTemplate();
			Data.DataFolder = "";
        }

		public DataTemplate Data { get; protected set; }
    }
}