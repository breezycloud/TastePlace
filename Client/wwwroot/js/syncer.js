let dotnetSyncObj
window.Syncer = {
    Initialize: function (interop) {
        dotnetSyncObj = interop;
    },
    Dispose: function () {
        if (dotnetSyncObj != null) {
            dotnetSyncObj.dispose();
        }
    }
}

function StartUpload() {
    dotnetSyncObj.invokeMethodAsync("StartSync", status);
}