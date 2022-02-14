﻿// Copyright 2021 Automate The Planet Ltd.
// Author: Anton Angelov
// Licensed under the Apache License, Version 2.0 (the "License");
// You may not use this file except in compliance with the License.
// You may obtain a copy of the License at http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StabilizeTestsDemos.FifthVersion
{
    public class BaseTestBehaviorObserver : ITestBehaviorObserver
    {
        private readonly ITestExecutionSubject _testExecutionSubject;

        public BaseTestBehaviorObserver(ITestExecutionSubject testExecutionSubject)
        {
            _testExecutionSubject = testExecutionSubject;
            testExecutionSubject.Attach(this);
        }

        public virtual void PreTestInit(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void PostTestInit(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void PreTestCleanup(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void PostTestCleanup(TestContext context, MemberInfo memberInfo)
        {
        }

        public virtual void TestInstantiated(MemberInfo memberInfo)
        {
        }
    }
}