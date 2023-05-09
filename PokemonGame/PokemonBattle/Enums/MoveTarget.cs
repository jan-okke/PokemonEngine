using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Enums;

public enum MoveTarget
{
    None,
    Other,
    NearOther,
    AllNearFoes,
    BothSides,
    User,
    UserSide,
    RandomNearFoe,
    FoeSide,
    AllNearOthers,
    AllBattlers,
    NearFoe,
    UserAndAllies,
    NearAlly,
    AllAllies,
    UserOrNearAlly,

}