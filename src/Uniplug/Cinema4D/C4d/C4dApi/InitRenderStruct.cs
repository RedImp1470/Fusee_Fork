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

public class InitRenderStruct : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal InitRenderStruct(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(InitRenderStruct obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~InitRenderStruct() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          C4dApiPINVOKE.delete_InitRenderStruct(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public InitRenderStruct() : this(C4dApiPINVOKE.new_InitRenderStruct__SWIG_0(), true) {
  }

  public InitRenderStruct(BaseDocument t_doc) : this(C4dApiPINVOKE.new_InitRenderStruct__SWIG_1(BaseDocument.getCPtr(t_doc)), true) {
  }

  public void Init(BaseDocument t_doc) {
    C4dApiPINVOKE.InitRenderStruct_Init(swigCPtr, BaseDocument.getCPtr(t_doc));
  }

  public int version {
    set {
      C4dApiPINVOKE.InitRenderStruct_version_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.InitRenderStruct_version_get(swigCPtr);
      return ret;
    } 
  }

  public BaseTime time {
    set {
      C4dApiPINVOKE.InitRenderStruct_time_set(swigCPtr, BaseTime.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.InitRenderStruct_time_get(swigCPtr);
      BaseTime ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseTime(cPtr, false);
      return ret;
    } 
  }

  public int fps {
    set {
      C4dApiPINVOKE.InitRenderStruct_fps_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.InitRenderStruct_fps_get(swigCPtr);
      return ret;
    } 
  }

  public Filename docpath {
    set {
      C4dApiPINVOKE.InitRenderStruct_docpath_set(swigCPtr, Filename.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.InitRenderStruct_docpath_get(swigCPtr);
      Filename ret = (cPtr == global::System.IntPtr.Zero) ? null : new Filename(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_String matname {
    set {
      C4dApiPINVOKE.InitRenderStruct_matname_set(swigCPtr, SWIGTYPE_p_String.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.InitRenderStruct_matname_get(swigCPtr);
      SWIGTYPE_p_String ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_String(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_RootTextureString errorlist {
    set {
      C4dApiPINVOKE.InitRenderStruct_errorlist_set(swigCPtr, SWIGTYPE_p_RootTextureString.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.InitRenderStruct_errorlist_get(swigCPtr);
      SWIGTYPE_p_RootTextureString ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_RootTextureString(cPtr, false);
      return ret;
    } 
  }

  public SWIGTYPE_p_VolumeData vd {
    set {
      C4dApiPINVOKE.InitRenderStruct_vd_set(swigCPtr, SWIGTYPE_p_VolumeData.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.InitRenderStruct_vd_get(swigCPtr);
      SWIGTYPE_p_VolumeData ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_VolumeData(cPtr, false);
      return ret;
    } 
  }

  public BaseDocument doc {
    set {
      C4dApiPINVOKE.InitRenderStruct_doc_set(swigCPtr, BaseDocument.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.InitRenderStruct_doc_get(swigCPtr);
      BaseDocument ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseDocument(cPtr, false);
      return ret;
    } 
  }

  public BaseThread thread {
    set {
      C4dApiPINVOKE.InitRenderStruct_thread_set(swigCPtr, BaseThread.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = C4dApiPINVOKE.InitRenderStruct_thread_get(swigCPtr);
      BaseThread ret = (cPtr == global::System.IntPtr.Zero) ? null : new BaseThread(cPtr, false);
      return ret;
    } 
  }

  public INITRENDERFLAG flags {
    set {
      C4dApiPINVOKE.InitRenderStruct_flags_set(swigCPtr, (int)value);
    } 
    get {
      INITRENDERFLAG ret = (INITRENDERFLAG)C4dApiPINVOKE.InitRenderStruct_flags_get(swigCPtr);
      return ret;
    } 
  }

  public bool linear_workflow {
    set {
      C4dApiPINVOKE.InitRenderStruct_linear_workflow_set(swigCPtr, value);
    } 
    get {
      bool ret = C4dApiPINVOKE.InitRenderStruct_linear_workflow_get(swigCPtr);
      return ret;
    } 
  }

  public int document_colorprofile {
    set {
      C4dApiPINVOKE.InitRenderStruct_document_colorprofile_set(swigCPtr, value);
    } 
    get {
      int ret = C4dApiPINVOKE.InitRenderStruct_document_colorprofile_get(swigCPtr);
      return ret;
    } 
  }

  public int GetThreadCount() {
    int ret = C4dApiPINVOKE.InitRenderStruct_GetThreadCount(swigCPtr);
    return ret;
  }

  public Fusee.Math.Core.double3 /* Vector_cstype_out */ TransformColor(Fusee.Math.Core.double3 /* constVector&_cstype */ input)  {  /* <Vector_csout> */
      Fusee.Math.Core.double3 ret = C4dApiPINVOKE.InitRenderStruct_TransformColor(swigCPtr, ref input /* constVector&_csin */);
      return ret;
   } /* <Vector_csout> */ 

}

}
