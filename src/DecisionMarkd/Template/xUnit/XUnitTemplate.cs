﻿namespace DecisionMarkd.Template.xUnit
{
    public class XUnitTemplate
    {
        public const string TEST_TEMPLATE = @"
namespace {{namespace_name}}
{
    using System;
    using System.Collections.Generic;
    using Xunit;

    public partial class {{class_name}}
    {
        [Theory]
        [MemberData(nameof(get_test_data))]
        public void {{class_name}}_tests({{parameter_declarations}})
        {
            {{class_name}}_implementation({{parameters}});
        }

        public static IEnumerable<object[]> get_test_data()
        {
            var data = new List<object[]>
            {
                {{#each list_of_test_data}}
                new object[] { {{{this}}} },
                {{/each}}
            };

            return data;
        }

        partial void {{class_name}}_implementation({{parameter_declarations}});
    }
}";

        public const string IMPLEMENTATION_TEMPLATE = @"
namespace {{namespace_name}}
{
    using System;

    public partial class {{class_name}}
    {
        partial void {{class_name}}_implementation({{parameter_declarations}})
        {
            throw new NotImplementedException();
        }
    }
}";
    }
}
