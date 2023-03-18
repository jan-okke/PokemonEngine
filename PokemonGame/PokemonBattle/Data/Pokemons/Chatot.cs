using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Chatot : Pokemon
	{
		public override string Name => "Chatot";
		public override List<Ability> AvailableAbilities => new() {new Keeneye(), new Tangledfeet() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Bigpecks() };
		public override Stats BaseStats => new Stats(76, 65, 45, 91, 92, 42);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Normal, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Hypervoice(), new Chatter(), new Confide(), new Taunt() },
			[5] = new List<Move>() { new Peck() },
			[9] = new List<Move>() { new Growl() },
			[13] = new List<Move>() { new Sing() },
			[17] = new List<Move>() { new Furyattack() },
			[21] = new List<Move>() { new Chatter() },
			[25] = new List<Move>() { new Taunt() },
			[29] = new List<Move>() { new Round() },
			[33] = new List<Move>() { new Mimic() },
			[37] = new List<Move>() { new Echoedvoice() },
			[41] = new List<Move>() { new Roost() },
			[45] = new List<Move>() { new Uproar() },
			[49] = new List<Move>() { new Partingshot() },
			[50] = new List<Move>() { new Featherdance() },
			[57] = new List<Move>() { new Hypervoice() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Confide(), new Defog(), new Doubleteam(), new Echoedvoice(), new Endure(), new Facade(), new Fly(), new Frustration(), new Heatwave(), new Hiddenpower(), new Hypervoice(), new Nastyplot(), new Pluck(), new Protect(), new Raindance(), new Rest(), new Return(), new Roleplay(), new Roost(), new Round(), new Skyattack(), new Sleeptalk(), new Snore(), new Steelwing(), new Substitute(), new Sunnyday(), new Swagger(), new Tailwind(), new Taunt(), new Thief(), new Torment(), new Uproar(), new Uturn(), new Workup() };
		public override List<Move> EggMoves => new List<Move>() { new Agility(), new Aircutter(), new Boomburst(), new Encore(), new Nightshade(), new Supersonic() };
		public override int Weight => 19;
		public override int ExpYield => 144;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 1,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}