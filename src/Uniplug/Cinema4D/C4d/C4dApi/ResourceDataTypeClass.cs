//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.10
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace C4d {

public class ResourceDataTypeClass : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ResourceDataTypeClass(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ResourceDataTypeClass obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ResourceDataTypeClass() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ResourceDataTypeClass(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual int GetId() {
    int ret = C4dApiPINVOKE.ResourceDataTypeClass_GetId(swigCPtr);
    return ret;
  }

  public virtual int GetCustomDataType() {
    int ret = C4dApiPINVOKE.ResourceDataTypeClass_GetCustomDataType(swigCPtr);
    return ret;
  }

  public virtual SWIGTYPE_p_CUSTOMDATATYPEPLUGIN GetCustomDataTypePlugin() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ResourceDataTypeClass_GetCustomDataTypePlugin(swigCPtr);
    SWIGTYPE_p_CUSTOMDATATYPEPLUGIN ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CUSTOMDATATYPEPLUGIN(cPtr, false);
    return ret;
  }

  public virtual void GetDefaultProperties(BaseContainer data) {
    C4dApiPINVOKE.ResourceDataTypeClass_GetDefaultProperties(swigCPtr, BaseContainer.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual SWIGTYPE_p_Char GetResourceSym() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ResourceDataTypeClass_GetResourceSym(swigCPtr);
    SWIGTYPE_p_Char ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Char(cPtr, false);
    return ret;
  }

  public virtual SWIGTYPE_p_CustomProperty GetProperties() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.ResourceDataTypeClass_GetProperties(swigCPtr);
    SWIGTYPE_p_CustomProperty ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_CustomProperty(cPtr, false);
    return ret;
  }

  public virtual bool GetDescription(CustomDataType data, Description res, SWIGTYPE_p_DESCFLAGS_DESC flags, BaseContainer parentdescription, DescID singledescid) {
    bool ret = C4dApiPINVOKE.ResourceDataTypeClass_GetDescription(swigCPtr, CustomDataType.getCPtr(data), Description.getCPtr(res), SWIGTYPE_p_DESCFLAGS_DESC.getCPtr(flags), BaseContainer.getCPtr(parentdescription), DescID.getCPtr(singledescid));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void CheckData(BaseContainer bc, GeData data) {
    C4dApiPINVOKE.ResourceDataTypeClass_CheckData(swigCPtr, BaseContainer.getCPtr(bc), GeData.getCPtr(data));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
