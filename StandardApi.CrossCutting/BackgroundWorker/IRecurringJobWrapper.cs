﻿using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace StandardApi.CrossCutting.BackgroundWorker
{
    public interface IRecurringJobWrapper
    {
        void AddOrUpdate(Expression<Action> methodCall, Func<string> cronExpression, TimeZoneInfo timeZone = null, string queue = "default");
        void AddOrUpdate(Expression<Action> methodCall, string cronExpression, TimeZoneInfo timeZone = null, string queue = "default");

        void AddOrUpdate<T>(Expression<Action<T>> methodCall, Func<string> cronExpression, TimeZoneInfo timeZone = null, string queue = "default");
        void AddOrUpdate<T>(Expression<Action<T>> methodCall, string cronExpression, TimeZoneInfo timeZone = null, string queue = "default");

        void AddOrUpdate(string recurringJobId, Expression<Action> methodCall, Func<string> cronExpression, TimeZoneInfo timeZone = null, string queue = "default");
        void AddOrUpdate(string recurringJobId, Expression<Action> methodCall, string cronExpression, TimeZoneInfo timeZone = null, string queue = "default");

        void AddOrUpdate<T>(string recurringJobId, Expression<Action<T>> methodCall, Func<string> cronExpression, TimeZoneInfo timeZone = null, string queue = "default");
        void AddOrUpdate<T>(string recurringJobId, Expression<Action<T>> methodCall, string cronExpression, TimeZoneInfo timeZone = null, string queue = "default");

        void AddOrUpdate(string recurringJobId, Expression<Func<Task>> methodCall, Func<string> cronExpression, TimeZoneInfo timeZone = null, string queue = "default");
        void AddOrUpdate(string recurringJobId, Expression<Func<Task>> methodCall, string cronExpression, TimeZoneInfo timeZone = null, string queue = "default");

        void AddOrUpdate<T>(string recurringJobId, Expression<Func<T, Task>> methodCall, Func<string> cronExpression, TimeZoneInfo timeZone = null, string queue = "default");
        void AddOrUpdate<T>(string recurringJobId, Expression<Func<T, Task>> methodCall, string cronExpression, TimeZoneInfo timeZone = null, string queue = "default");

        void RemoveIfExists(string recurringJobId);
    }
}
