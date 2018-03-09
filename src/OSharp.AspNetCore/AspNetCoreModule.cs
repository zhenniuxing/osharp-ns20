﻿// -----------------------------------------------------------------------
//  <copyright file="AspNetCoreModule.cs" company="OSharp开源团队">
//      Copyright (c) 2014-2018 OSharp. All rights reserved.
//  </copyright>
//  <site>http://www.osharp.org</site>
//  <last-editor>郭明锋</last-editor>
//  <last-date>2018-03-09 21:52</last-date>
// -----------------------------------------------------------------------

using Microsoft.Extensions.DependencyInjection;

using OSharp.AspNetCore.Infrastructure;
using OSharp.Core.Modules;
using OSharp.Dependency;


namespace OSharp.AspNetCore
{
    /// <summary>
    /// AspNetCore模块
    /// </summary>
    public class AspNetCoreModule : OSharpModule
    {
        /// <summary>
        /// 获取 是否内部模块，内部模块将自动加载
        /// </summary>
        public override bool IsAutoLoad => true;

        /// <summary>
        /// 将模块服务添加到依赖注入服务容器中
        /// </summary>
        /// <param name="services">依赖注入服务容器</param>
        /// <returns></returns>
        public override IServiceCollection AddServices(IServiceCollection services)
        {
            services.AddSingleton<IScopedServiceResolver, RequestScopedServiceResolver>();

            return services;
        }
    }
}