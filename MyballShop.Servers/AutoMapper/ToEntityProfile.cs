﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyballShop.Servers.AutoMapper
{
	public class ToEntityProfile : Profile
	{
		public override string ProfileName
		{
			get
			{
				return "ToDTOProfile";
			}
		}

		public ToEntityProfile()
		{

		}
	}
}