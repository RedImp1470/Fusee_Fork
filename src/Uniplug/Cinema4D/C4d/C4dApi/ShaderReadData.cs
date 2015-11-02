/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace C4d {

public class ShaderReadData : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ShaderReadData(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ShaderReadData obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ShaderReadData() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_ShaderReadData(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public HyperFile hf {
    set {
      C4dApiPINVOKE.ShaderReadData_hf_set(swigCPtr, HyperFile.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ShaderReadData_hf_get(swigCPtr);
      HyperFile ret = (cPtr == global::System.IntPtr.Zero) ? null : new HyperFile(cPtr, false);
      return ret;
    } 
  }

  public int oldid {
    set {
      C4dApiPINVOKE.ShaderReadData_oldid_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ShaderReadData_oldid_get(swigCPtr);
      return ret;
    } 
  }

  public SWIGTYPE_p_Float data {
    set {
      C4dApiPINVOKE.ShaderReadData_data_set(swigCPtr, SWIGTYPE_p_Float.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ShaderReadData_data_get(swigCPtr);
      SWIGTYPE_p_Float ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_Float(cPtr, false);
      return ret;
    } 
  }

  public int oldlevel {
    set {
      C4dApiPINVOKE.ShaderReadData_oldlevel_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.ShaderReadData_oldlevel_get(swigCPtr);
      return ret;
    } 
  }

  public BaseContainer oldctr {
    set {
      C4dApiPINVOKE.ShaderReadData_oldctr_set(swigCPtr, BaseContainer.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.ShaderReadData_oldctr_get(swigCPtr);
      BaseContainer ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseContainer(cPtr, false);
      return ret;
    } 
  }

  public ShaderReadData() : this(C4dApiPINVOKE.new_ShaderReadData(), true) {
  }

}

}
