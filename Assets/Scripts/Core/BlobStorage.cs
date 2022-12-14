using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Mondeto.Core
{

public class BlobStorage
{
    ConcurrentDictionary<BlobHandle, TaskCompletionSource<Blob>> dict = new ConcurrentDictionary<BlobHandle, TaskCompletionSource<Blob>>();

    public void Write(BlobHandle handle, Blob blob)
    {
        Logger.Debug("BlobStorage", $"Blob {handle} writing");

        var tcs = dict.GetOrAdd(handle, new TaskCompletionSource<Blob>());
        if (tcs.Task.IsCompleted)
        {
            Logger.Error("BlobStorage", $"Trying to overwrite {handle}. Ignoring");
            return;
        }
        tcs.SetResult(blob);
    }

    public Task<Blob> Read(BlobHandle handle)
    {
        return dict.GetOrAdd(handle, new TaskCompletionSource<Blob>()).Task;
    }
}

} // end namespace