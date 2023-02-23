﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.PokemonBattle.Enums
{
    public enum EffectType
    {
        Charged, // Charge used earlier
        HelpingHand, // Helping Hand applied
        MetronomeStack, // Metronome Turn (set to 1 if Metronome on Move and last move != currentMove, otherwise += 1) => TODO THIS IS GONNA BE NOT EASY
        AquaRing, // Aqua Ring used
        Protect, // protected
        BanefulBunker // Baneful Bunker
    }
}
