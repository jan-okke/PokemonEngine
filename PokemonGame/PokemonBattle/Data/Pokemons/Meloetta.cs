using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Meloetta : Pokemon
	{
		public override string Name => "Meloetta";
		public override List<Ability> AvailableAbilities => new() {new Serenegrace() };
		public override Stats BaseStats => new Stats(100, 77, 77, 128, 128, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Round(), new Quickattack(), new Confusion(), new Sing() },
			[6] = new List<Move>() { new Quickattack() },
			[11] = new List<Move>() { new Confusion() },
			[16] = new List<Move>() { new Sing() },
			[21] = new List<Move>() { new Teeterdance() },
			[26] = new List<Move>() { new Acrobatics() },
			[31] = new List<Move>() { new Psybeam() },
			[36] = new List<Move>() { new Echoedvoice() },
			[43] = new List<Move>() { new Uturn() },
			[50] = new List<Move>() { new Wakeupslap() },
			[57] = new List<Move>() { new Psychic() },
			[64] = new List<Move>() { new Hypervoice() },
			[71] = new List<Move>() { new Roleplay() },
			[78] = new List<Move>() { new Closecombat() },
			[85] = new List<Move>() { new Perishsong() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Brickbreak(), new Calmmind(), new Chargebeam(), new Confide(), new Covet(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Dreameater(), new Dualchop(), new Echoedvoice(), new Embargo(), new Energyball(), new Facade(), new Firepunch(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gigaimpact(), new Grassknot(), new Gravity(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icepunch(), new Knockoff(), new Laserfocus(), new Lastresort(), new Lightscreen(), new Lowkick(), new Lowsweep(), new Magiccoat(), new Magicroom(), new Payback(), new Poweruppunch(), new Protect(), new Psychic(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Relicsong(), new Rest(), new Return(), new Rocksmash(), new Roleplay(), new Round(), new Safeguard(), new Shadowball(), new Shadowclaw(), new Shockwave(), new Signalbeam(), new Skillswap(), new Sleeptalk(), new Snatch(), new Snore(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Telekinesis(), new Thunder(), new Thunderbolt(), new Thunderpunch(), new Thunderwave(), new Toxic(), new Trick(), new Trickroom(), new Uproar(), new Uturn(), new Wonderroom(), new Workup(), new Zenheadbutt() };
		public override int Weight => 65;
		public override int ExpYield => 300;
		public override int CatchRate => 3;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 1,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 1
		};
	}
}