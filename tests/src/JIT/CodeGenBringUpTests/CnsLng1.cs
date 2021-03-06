// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.
//


using System;
using System.Runtime.CompilerServices;
public class BringUpTest
{
    const int Pass = 100;
    const int Fail = -1;

    [MethodImplAttribute(MethodImplOptions.NoInlining)]
    public static long CnsLng1() { return 1; }

    public static int Main()
    {
        long y = CnsLng1();
        if (y == 1) return Pass;
        else return Fail;
    }
}
