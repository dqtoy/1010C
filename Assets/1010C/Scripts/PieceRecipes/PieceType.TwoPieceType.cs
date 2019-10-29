﻿using UnityEngine;

namespace _1010C.Scripts.PieceRecipes
{
    public abstract partial class PieceType
    {
        private abstract class TwoPieceType : PieceType
        {
            public static readonly TwoPieceType mTwoPieceVertical = new TwoPieceVertical();
            public static readonly TwoPieceType mTwoPieceHorizontal = new TwoPieceHorizontal();

            private TwoPieceType(int value, string name) : base(value, name)
            {
            }

            public override float GetCubeSeparationAmount()
            {
                return 0.086f;
            }

            private class TwoPieceVertical : TwoPieceType
            {
                public TwoPieceVertical() : base(1, "TwoPieceVertical")
                {
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(0, -0.5f),
                        new Vector2(0, +0.5f),
                    };
                }
            }

            private class TwoPieceHorizontal : TwoPieceType
            {
                public TwoPieceHorizontal() : base(2, "TwoPieceHorizontal")
                {
                }

                public override Vector2[] GetPiecePositions()
                {
                    return new[]
                    {
                        new Vector2(-0.5f, 0),
                        new Vector2(+0.5f, 0),
                    };
                }
            }
        }
    }
}