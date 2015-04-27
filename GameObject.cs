using System;
using System.Collections.Generic;
namespace CSCD349Project
{
    public class GameObject
    {
        private Cell _occupyingCell{get;set;}
        private Sprite _sprite{get;set;}
        private GameObjectType _type{get;set;}
        private string _name{get;set;}

        public GameObject(string name)
        {
            _name = name;
        }
        
    }



    public enum GameObjectType{gameCharacter, gameItem, }

    public class Sprite
    {
        public Sprite(string path)
        {

        }
        
    }









}
