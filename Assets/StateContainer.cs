using System;

internal class StateContainer
{
    #region Singleton
    private static StateContainer _inner;

    public static StateContainer Instance
    {
        get
        {
            if (_inner == null)
            {
                _inner = new StateContainer();
            }
            return _inner;
        }
    }

    private StateContainer() { }
    #endregion

    #region State
    public int[] hits = new int[] { 0, 0, 0, 0, 0 };
    #endregion

    #region Methods
    internal void particleHit(int floorNumber)
    {
        hits[floorNumber - 1] = hits[floorNumber - 1] + 1;
    }
    #endregion

}