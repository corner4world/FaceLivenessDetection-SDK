/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.FaceLivenessDetection.Sdk {

using System;
using System.Runtime.InteropServices;

public class FldSdkEngine : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal FldSdkEngine(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(FldSdkEngine obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~FldSdkEngine() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          FaceLivenessDetectionSDKPINVOKE.delete_FldSdkEngine(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static FldSdkResult init(string jsonConfig, FldSdkParallelDeliveryCallback parallelDeliveryCallback) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_init__SWIG_0(jsonConfig, FldSdkParallelDeliveryCallback.getCPtr(parallelDeliveryCallback)), true);
    return ret;
  }

  public static FldSdkResult init(string jsonConfig) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_init__SWIG_1(jsonConfig), true);
    return ret;
  }

  public static FldSdkResult init() {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_init__SWIG_2(), true);
    return ret;
  }

  public static FldSdkResult deInit() {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_deInit(), true);
    return ret;
  }

  public static FldSdkResult process(FLD_SDK_IMAGE_TYPE imageType, IntPtr imageData, uint imageWidthInSamples, uint imageHeightInSamples, uint imageStrideInSamples, int imageExifOrientation) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_process__SWIG_0((int)imageType, imageData, imageWidthInSamples, imageHeightInSamples, imageStrideInSamples, imageExifOrientation), true);
    return ret;
  }

  public static FldSdkResult process(FLD_SDK_IMAGE_TYPE imageType, IntPtr imageData, uint imageWidthInSamples, uint imageHeightInSamples, uint imageStrideInSamples) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_process__SWIG_1((int)imageType, imageData, imageWidthInSamples, imageHeightInSamples, imageStrideInSamples), true);
    return ret;
  }

  public static FldSdkResult process(FLD_SDK_IMAGE_TYPE imageType, IntPtr imageData, uint imageWidthInSamples, uint imageHeightInSamples) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_process__SWIG_2((int)imageType, imageData, imageWidthInSamples, imageHeightInSamples), true);
    return ret;
  }

  public static FldSdkResult process(FLD_SDK_IMAGE_TYPE imageType, IntPtr yPtr, IntPtr uPtr, IntPtr vPtr, uint widthInSamples, uint heightInSamples, uint yStrideInBytes, uint uStrideInBytes, uint vStrideInBytes, uint uvPixelStrideInBytes, int exifOrientation) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_process__SWIG_3((int)imageType, yPtr, uPtr, vPtr, widthInSamples, heightInSamples, yStrideInBytes, uStrideInBytes, vStrideInBytes, uvPixelStrideInBytes, exifOrientation), true);
    return ret;
  }

  public static FldSdkResult process(FLD_SDK_IMAGE_TYPE imageType, IntPtr yPtr, IntPtr uPtr, IntPtr vPtr, uint widthInSamples, uint heightInSamples, uint yStrideInBytes, uint uStrideInBytes, uint vStrideInBytes, uint uvPixelStrideInBytes) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_process__SWIG_4((int)imageType, yPtr, uPtr, vPtr, widthInSamples, heightInSamples, yStrideInBytes, uStrideInBytes, vStrideInBytes, uvPixelStrideInBytes), true);
    return ret;
  }

  public static FldSdkResult process(FLD_SDK_IMAGE_TYPE imageType, IntPtr yPtr, IntPtr uPtr, IntPtr vPtr, uint widthInSamples, uint heightInSamples, uint yStrideInBytes, uint uStrideInBytes, uint vStrideInBytes) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_process__SWIG_5((int)imageType, yPtr, uPtr, vPtr, widthInSamples, heightInSamples, yStrideInBytes, uStrideInBytes, vStrideInBytes), true);
    return ret;
  }

  public static FldSdkResult requestRuntimeLicenseKey(bool rawInsteadOfJSON) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_requestRuntimeLicenseKey__SWIG_0(rawInsteadOfJSON), true);
    return ret;
  }

  public static FldSdkResult requestRuntimeLicenseKey() {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_requestRuntimeLicenseKey__SWIG_1(), true);
    return ret;
  }

  public static FldSdkResult warmUp(FLD_SDK_IMAGE_TYPE imageType) {
    FldSdkResult ret = new FldSdkResult(FaceLivenessDetectionSDKPINVOKE.FldSdkEngine_warmUp((int)imageType), true);
    return ret;
  }

}

}
