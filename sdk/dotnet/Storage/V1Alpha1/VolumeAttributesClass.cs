// *** WARNING: this file was generated by pulumigen. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Kubernetes.Storage.V1Alpha1
{
    /// <summary>
    /// VolumeAttributesClass represents a specification of mutable volume attributes defined by the CSI driver. The class can be specified during dynamic provisioning of PersistentVolumeClaims, and changed in the PersistentVolumeClaim spec after provisioning.
    /// </summary>
    [KubernetesResourceType("kubernetes:storage.k8s.io/v1alpha1:VolumeAttributesClass")]
    public partial class VolumeAttributesClass : KubernetesResource
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Output("apiVersion")]
        public Output<string> ApiVersion { get; private set; } = null!;

        /// <summary>
        /// Name of the CSI driver This field is immutable.
        /// </summary>
        [Output("driverName")]
        public Output<string> DriverName { get; private set; } = null!;

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Output("kind")]
        public Output<string> Kind { get; private set; } = null!;

        /// <summary>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [Output("metadata")]
        public Output<Pulumi.Kubernetes.Types.Outputs.Meta.V1.ObjectMeta> Metadata { get; private set; } = null!;

        /// <summary>
        /// parameters hold volume attributes defined by the CSI driver. These values are opaque to the Kubernetes and are passed directly to the CSI driver. The underlying storage provider supports changing these attributes on an existing volume, however the parameters field itself is immutable. To invoke a volume update, a new VolumeAttributesClass should be created with new parameters, and the PersistentVolumeClaim should be updated to reference the new VolumeAttributesClass.
        /// 
        /// This field is required and must contain at least one key/value pair. The keys cannot be empty, and the maximum number of parameters is 512, with a cumulative max size of 256K. If the CSI driver rejects invalid parameters, the target PersistentVolumeClaim will be set to an "Infeasible" state in the modifyVolumeStatus field.
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, string>> Parameters { get; private set; } = null!;


        /// <summary>
        /// Create a VolumeAttributesClass resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public VolumeAttributesClass(string name, Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.VolumeAttributesClassArgs? args = null, CustomResourceOptions? options = null)
            : base("kubernetes:storage.k8s.io/v1alpha1:VolumeAttributesClass", name, MakeArgs(args), MakeResourceOptions(options, ""))
        {
        }
        internal VolumeAttributesClass(string name, ImmutableDictionary<string, object?> dictionary, CustomResourceOptions? options = null)
            : base("kubernetes:storage.k8s.io/v1alpha1:VolumeAttributesClass", name, new DictionaryResourceArgs(dictionary), MakeResourceOptions(options, ""))
        {
        }

        private VolumeAttributesClass(string name, Input<string> id, CustomResourceOptions? options = null)
            : base("kubernetes:storage.k8s.io/v1alpha1:VolumeAttributesClass", name, null, MakeResourceOptions(options, id))
        {
        }

        private static Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.VolumeAttributesClassArgs? MakeArgs(Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.VolumeAttributesClassArgs? args)
        {
            args ??= new Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1.VolumeAttributesClassArgs();
            args.ApiVersion = "storage.k8s.io/v1alpha1";
            args.Kind = "VolumeAttributesClass";
            return args;
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new global::Pulumi.Alias { Type = "kubernetes:storage.k8s.io/v1beta1:VolumeAttributesClass" },
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing VolumeAttributesClass resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static VolumeAttributesClass Get(string name, Input<string> id, CustomResourceOptions? options = null)
        {
            return new VolumeAttributesClass(name, id, options);
        }
    }
}
namespace Pulumi.Kubernetes.Types.Inputs.Storage.V1Alpha1
{

    public class VolumeAttributesClassArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// APIVersion defines the versioned schema of this representation of an object. Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        /// </summary>
        [Input("apiVersion")]
        public Input<string>? ApiVersion { get; set; }

        /// <summary>
        /// Name of the CSI driver This field is immutable.
        /// </summary>
        [Input("driverName", required: true)]
        public Input<string> DriverName { get; set; } = null!;

        /// <summary>
        /// Kind is a string value representing the REST resource this object represents. Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        /// </summary>
        [Input("kind")]
        public Input<string>? Kind { get; set; }

        /// <summary>
        /// Standard object's metadata. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        /// </summary>
        [Input("metadata")]
        public Input<Pulumi.Kubernetes.Types.Inputs.Meta.V1.ObjectMetaArgs>? Metadata { get; set; }

        [Input("parameters")]
        private InputMap<string>? _parameters;

        /// <summary>
        /// parameters hold volume attributes defined by the CSI driver. These values are opaque to the Kubernetes and are passed directly to the CSI driver. The underlying storage provider supports changing these attributes on an existing volume, however the parameters field itself is immutable. To invoke a volume update, a new VolumeAttributesClass should be created with new parameters, and the PersistentVolumeClaim should be updated to reference the new VolumeAttributesClass.
        /// 
        /// This field is required and must contain at least one key/value pair. The keys cannot be empty, and the maximum number of parameters is 512, with a cumulative max size of 256K. If the CSI driver rejects invalid parameters, the target PersistentVolumeClaim will be set to an "Infeasible" state in the modifyVolumeStatus field.
        /// </summary>
        public InputMap<string> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<string>());
            set => _parameters = value;
        }

        public VolumeAttributesClassArgs()
        {
        }
        public static new VolumeAttributesClassArgs Empty => new VolumeAttributesClassArgs();
    }
}
