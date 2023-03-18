using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Sawsbuck : Pokemon
	{
		public override string Name => "Sawsbuck";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Serenegrace() };
		public override Stats BaseStats => new Stats(80, 100, 70, 60, 70, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Hornleech() },
			[1] = new List<Move>() { new Hornleech(), new Megahorn(), new Tackle(), new Camouflage(), new Growl(), new Sandattack() },
			[4] = new List<Move>() { new Growl() },
			[7] = new List<Move>() { new Sandattack() },
			[10] = new List<Move>() { new Doublekick() },
			[13] = new List<Move>() { new Leechseed() },
			[16] = new List<Move>() { new Feintattack() },
			[20] = new List<Move>() { new Takedown() },
			[24] = new List<Move>() { new Jumpkick() },
			[28] = new List<Move>() { new Aromatherapy() },
			[32] = new List<Move>() { new Energyball() },
			[36] = new List<Move>() { new Charm() },
			[44] = new List<Move>() { new Naturepower() },
			[52] = new List<Move>() { new Doubleedge() },
			[60] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Confide(), new Cut(), new Doubleteam(), new Echoedvoice(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Lastresort(), new Lightscreen(), new Naturepower(), new Protect(), new Raindance(), new Rest(), new Return(), new Rocksmash(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Stompingtantrum(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thunderwave(), new Toxic(), new Wildcharge(), new Workup(), new Worryseed() };
		public override int Weight => 925;
		public override int ExpYield => 166;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}