using UnityEngine;
using System.Collections;

/// <summary>
/// class BoolLike a where
///     fromBoolLike :: a -> Bool
/// </summary>
interface IBoolLike<A>
{
    bool FromBoolLike(A a);
}

class BoolLike
{
    public static bool FromBoolLike(int a)
    {
        return new IntBoolLike().FromBoolLike(a);
    }

    public static bool FromBoolLike<A>(Maybe<A> a)
    {
        return new MaybeBoolLike<A>().FromBoolLike(a);
    }

    public static bool FromBoolLike(bool a)
    {
        return new BoolBoolLike().FromBoolLike(a);
    }
}

/// <summary>
/// instance BoolLike Int where
///     fromBoolLike = (0 /=)
/// </summary>
class IntBoolLike : IBoolLike<int>
{
    public bool FromBoolLike(int a)
    {
        return a != 0;
    }
}

/// <summary>
/// instance BoolLike (Maybe a) where
///     fromBoolLike Nothing  = False
///     fromBoolLike (Just _) = True
/// </summary>
/// <typeparam name="A"></typeparam>
class MaybeBoolLike<A> : IBoolLike<Maybe<A>>
{
    public bool FromBoolLike(Maybe<A> a)
    {
        if (a is Nothing<A>) return false;
        else return true;
    }
}

/// <summary>
/// instance BoolLike Bool where
///     fromBoolLike x = x
/// </summary>
class BoolBoolLike : IBoolLike<bool>
{
    public bool FromBoolLike(bool a)
    {
        return a;
    }
}