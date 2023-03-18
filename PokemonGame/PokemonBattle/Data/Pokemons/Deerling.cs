using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Deerling : Pokemon
	{
		public override string Name => "Deerling";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll(), new Sapsipper() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Serenegrace() };
		public override Stats BaseStats => new Stats(60, 60, 50, 40, 50, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Tackle(), new Camouflage() },
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
			[41] = new List<Move>() { new Naturepower() },
			[46] = new List<Move>() { new Doubleedge() },
			[51] = new List<Move>() { new Solarbeam() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Confide(), new Doubleteam(), new Echoedvoice(), new Energyball(), new Facade(), new Frustration(), new Gigadrain(), new Grassknot(), new Hiddenpower(), new Lastresort(), new Lightscreen(), new Naturepower(), new Protect(), new Raindance(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Synthesis(), new Thunderwave(), new Toxic(), new Wildcharge(), new Workup(), new Worryseed() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Batonpass(), new Faketears(), new Grasswhistle(), new Headbutt(), new Naturalgift(), new Odorsleuth(), new Sleeptalk(), new Synthesis(), new Worryseed() };
		public override int Weight => 195;
		public override int ExpYield => 67;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 1
		};
	}
}