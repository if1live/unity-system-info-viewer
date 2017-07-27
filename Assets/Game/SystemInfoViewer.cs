using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class SystemInfoViewer : MonoBehaviour {
    Text text;
	void Start () {
        text = GetComponentInChildren<Text>();
        Refresh();
	}

    void BuildMessage(StringBuilder sb, string key, object val) {
        var msg = string.Format("{0}: {1}", key, val);
        sb.AppendLine(msg);
        Debug.Log(msg);
    }

    void Refresh() {
        var sb = new StringBuilder();

        sb.AppendLine("## Device");
        BuildMessage(sb, "DeviceModel", SystemInfo.deviceModel);
        BuildMessage(sb, "DeviceName", SystemInfo.deviceName);
        BuildMessage(sb, "DeviceType", SystemInfo.deviceType);
        BuildMessage(sb, "DeviceUID", SystemInfo.deviceUniqueIdentifier);

        sb.AppendLine("## Graphics");
        BuildMessage(sb, "GraphicsDeviceID", SystemInfo.graphicsDeviceID);
        BuildMessage(sb, "GraphicsDeviceID", SystemInfo.graphicsDeviceID);
        BuildMessage(sb, "GraphicsDeviceName", SystemInfo.graphicsDeviceName);
        BuildMessage(sb, "GraphicsDeviceType", SystemInfo.graphicsDeviceType);
        BuildMessage(sb, "GraphicsDeviceVendor", SystemInfo.graphicsDeviceVendor);
        BuildMessage(sb, "GraphicsDeviceVendorID", SystemInfo.graphicsDeviceVendorID);
        BuildMessage(sb, "GraphicsDeviceVersion", SystemInfo.graphicsDeviceVersion);
        BuildMessage(sb, "GraphicsMemorySize", SystemInfo.graphicsMemorySize);
        BuildMessage(sb, "GraphicsMultiThreaded", SystemInfo.graphicsMultiThreaded);
        BuildMessage(sb, "GraphicsShaderLevel", SystemInfo.graphicsShaderLevel);
        BuildMessage(sb, "GraphicsUVStartsAtTop", SystemInfo.graphicsUVStartsAtTop);

        text.text = sb.ToString();
    }
}

