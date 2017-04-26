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

public class MemoryFileStruct : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MemoryFileStruct(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MemoryFileStruct obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static MemoryFileStruct Alloc() {
    global::System.IntPtr cPtr = C4dApiPINVOKE.MemoryFileStruct_Alloc();
    MemoryFileStruct ret = (cPtr == global::System.IntPtr.Zero) ? null : new MemoryFileStruct(cPtr, false);
    return ret;
  }

  public static void Free(SWIGTYPE_p_p_MemoryFileStruct mfs) {
    C4dApiPINVOKE.MemoryFileStruct_Free(SWIGTYPE_p_p_MemoryFileStruct.getCPtr(mfs));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetData(SWIGTYPE_p_p_void data, SWIGTYPE_p_Int size) {
    C4dApiPINVOKE.MemoryFileStruct_GetData__SWIG_0(swigCPtr, SWIGTYPE_p_p_void.getCPtr(data), SWIGTYPE_p_Int.getCPtr(size));
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetData(SWIGTYPE_p_p_void data, SWIGTYPE_p_Int size, bool release) {
    C4dApiPINVOKE.MemoryFileStruct_GetData__SWIG_1(swigCPtr, SWIGTYPE_p_p_void.getCPtr(data), SWIGTYPE_p_Int.getCPtr(size), release);
    if (C4dApiPINVOKE.SWIGPendingException.Pending) throw C4dApiPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
