using RealGoodApps.OpenApiExampleAnnotations.Attributes;

namespace OpenApiExampleAnnotations.TestModels
{
    public sealed class TestResponseModel
    {
        [Example("abc123")]
        public List<string>? SomeStrings { get; set; }

        // Example of a child that would lead to an infinite loop without guards.
        public TestResponseModel? ChildModel { get; set; }

        public NestedModel? NestedModel { get; set; }

        public IEnumerable<ListItemModel>? ListItems { get; set; }

        [Example(5, true)]
        public IDictionary<int, bool>? SomeDictionary { get; set; }
    }

    public sealed class NestedModel
    {
        [Example("24")]
        public int TestValue { get; set; }
    }

    public sealed class ListItemModel
    {
        [Example(5.5f)]
        public float TestFloatValue { get; set; }
    }
}
