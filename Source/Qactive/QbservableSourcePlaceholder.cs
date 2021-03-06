﻿using System;
using System.Linq.Expressions;
using System.Reactive.Linq;

namespace Qactive
{
#if SERIALIZATION
  [Serializable]
#endif
  internal sealed class QbservableSourcePlaceholder<T> : IQbservable<T>
  {
    public Type ElementType
    {
      get
      {
        throw new NotSupportedException();
      }
    }

    public Expression Expression
    {
      get
      {
        throw new NotSupportedException();
      }
    }

    public IQbservableProvider Provider
    {
      get
      {
        throw new NotSupportedException();
      }
    }

    public IDisposable Subscribe(IObserver<T> observer)
    {
      throw new NotSupportedException();
    }
  }
}