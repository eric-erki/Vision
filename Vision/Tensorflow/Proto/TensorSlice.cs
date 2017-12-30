// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: tensor_slice.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Vision.Tensorflow.Proto {

  /// <summary>Holder for reflection information generated from tensor_slice.proto</summary>
  public static partial class TensorSliceReflection {

    #region Descriptor
    /// <summary>File descriptor for tensor_slice.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TensorSliceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJ0ZW5zb3Jfc2xpY2UucHJvdG8SCnRlbnNvcmZsb3cigAEKEFRlbnNvclNs",
            "aWNlUHJvdG8SMwoGZXh0ZW50GAEgAygLMiMudGVuc29yZmxvdy5UZW5zb3JT",
            "bGljZVByb3RvLkV4dGVudBo3CgZFeHRlbnQSDQoFc3RhcnQYASABKAMSEAoG",
            "bGVuZ3RoGAIgASgDSABCDAoKaGFzX2xlbmd0aEIyChhvcmcudGVuc29yZmxv",
            "dy5mcmFtZXdvcmtCEVRlbnNvclNsaWNlUHJvdG9zUAH4AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Vision.Tensorflow.Proto.TensorSliceProto), global::Vision.Tensorflow.Proto.TensorSliceProto.Parser, new[]{ "Extent" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Vision.Tensorflow.Proto.TensorSliceProto.Types.Extent), global::Vision.Tensorflow.Proto.TensorSliceProto.Types.Extent.Parser, new[]{ "Start", "Length" }, new[]{ "HasLength" }, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Can only be interpreted if you know the corresponding TensorShape.
  /// </summary>
  public sealed partial class TensorSliceProto : pb::IMessage<TensorSliceProto> {
    private static readonly pb::MessageParser<TensorSliceProto> _parser = new pb::MessageParser<TensorSliceProto>(() => new TensorSliceProto());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TensorSliceProto> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Vision.Tensorflow.Proto.TensorSliceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorSliceProto() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorSliceProto(TensorSliceProto other) : this() {
      extent_ = other.extent_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TensorSliceProto Clone() {
      return new TensorSliceProto(this);
    }

    /// <summary>Field number for the "extent" field.</summary>
    public const int ExtentFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Vision.Tensorflow.Proto.TensorSliceProto.Types.Extent> _repeated_extent_codec
        = pb::FieldCodec.ForMessage(10, global::Vision.Tensorflow.Proto.TensorSliceProto.Types.Extent.Parser);
    private readonly pbc::RepeatedField<global::Vision.Tensorflow.Proto.TensorSliceProto.Types.Extent> extent_ = new pbc::RepeatedField<global::Vision.Tensorflow.Proto.TensorSliceProto.Types.Extent>();
    /// <summary>
    /// Extent of the slice in all tensor dimensions.
    ///
    /// Must have one entry for each of the dimension of the tensor that this
    /// slice belongs to.  The order of sizes is the same as the order of
    /// dimensions in the TensorShape.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Vision.Tensorflow.Proto.TensorSliceProto.Types.Extent> Extent {
      get { return extent_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TensorSliceProto);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TensorSliceProto other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!extent_.Equals(other.extent_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= extent_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      extent_.WriteTo(output, _repeated_extent_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += extent_.CalculateSize(_repeated_extent_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TensorSliceProto other) {
      if (other == null) {
        return;
      }
      extent_.Add(other.extent_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            extent_.AddEntriesFrom(input, _repeated_extent_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the TensorSliceProto message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Extent of the slice in one dimension.
      /// </summary>
      public sealed partial class Extent : pb::IMessage<Extent> {
        private static readonly pb::MessageParser<Extent> _parser = new pb::MessageParser<Extent>(() => new Extent());
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Extent> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Vision.Tensorflow.Proto.TensorSliceProto.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Extent() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Extent(Extent other) : this() {
          start_ = other.start_;
          switch (other.HasLengthCase) {
            case HasLengthOneofCase.Length:
              Length = other.Length;
              break;
          }

        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Extent Clone() {
          return new Extent(this);
        }

        /// <summary>Field number for the "start" field.</summary>
        public const int StartFieldNumber = 1;
        private long start_;
        /// <summary>
        /// Start index of the slice, starting at 0.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long Start {
          get { return start_; }
          set {
            start_ = value;
          }
        }

        /// <summary>Field number for the "length" field.</summary>
        public const int LengthFieldNumber = 2;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public long Length {
          get { return hasLengthCase_ == HasLengthOneofCase.Length ? (long) hasLength_ : 0L; }
          set {
            hasLength_ = value;
            hasLengthCase_ = HasLengthOneofCase.Length;
          }
        }

        private object hasLength_;
        /// <summary>Enum of possible cases for the "has_length" oneof.</summary>
        public enum HasLengthOneofCase {
          None = 0,
          Length = 2,
        }
        private HasLengthOneofCase hasLengthCase_ = HasLengthOneofCase.None;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public HasLengthOneofCase HasLengthCase {
          get { return hasLengthCase_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void ClearHasLength() {
          hasLengthCase_ = HasLengthOneofCase.None;
          hasLength_ = null;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Extent);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Extent other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Start != other.Start) return false;
          if (Length != other.Length) return false;
          if (HasLengthCase != other.HasLengthCase) return false;
          return true;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (Start != 0L) hash ^= Start.GetHashCode();
          if (hasLengthCase_ == HasLengthOneofCase.Length) hash ^= Length.GetHashCode();
          hash ^= (int) hasLengthCase_;
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output) {
          if (Start != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(Start);
          }
          if (hasLengthCase_ == HasLengthOneofCase.Length) {
            output.WriteRawTag(16);
            output.WriteInt64(Length);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (Start != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Start);
          }
          if (hasLengthCase_ == HasLengthOneofCase.Length) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(Length);
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Extent other) {
          if (other == null) {
            return;
          }
          if (other.Start != 0L) {
            Start = other.Start;
          }
          switch (other.HasLengthCase) {
            case HasLengthOneofCase.Length:
              Length = other.Length;
              break;
          }

        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                input.SkipLastField();
                break;
              case 8: {
                Start = input.ReadInt64();
                break;
              }
              case 16: {
                Length = input.ReadInt64();
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code