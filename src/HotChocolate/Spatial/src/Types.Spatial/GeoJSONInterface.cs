using HotChocolate.Types;

namespace Types.Spatial
{
    public class GeoJSONInterface : InterfaceType
    {
        protected override void Configure(IInterfaceTypeDescriptor descriptor)
        {
            descriptor.Name(nameof(GeoJSONInterface));

            descriptor.Field("type")
                .Type<NonNullType<EnumType<GeoJSONGeometryType>>>()
                .Description("Type of the GeoJSON Object");

            descriptor.Field("bbox")
                .Type<ListType<FloatType>>();
        }
    }
}
