﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    /// <summary>
    /// 肩甲装饰器
    /// </summary>
    public class DecoratorShoulder : BaseDecorator
    {
        private BaseCharacter _BaseCharacter = null;
        public DecoratorShoulder(BaseCharacter character)
            : base(character)
        {
            this._BaseCharacter = character;
        }

        public override void Show()
        {
            this._BaseCharacter.Show();

            Console.WriteLine("我获取到一个肩甲。。凌风肩甲");
        }
    }
}
