using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Karrablast : Pokemon
	{
		public override string Name => "Karrablast";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Shedskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Noguard() };
		public override Stats BaseStats => new Stats(50, 75, 45, 40, 45, 60);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Peck(), new Leer() },
			[4] = new List<Move>() { new Furycutter() },
			[8] = new List<Move>() { new Endure() },
			[12] = new List<Move>() { new Falseswipe() },
			[16] = new List<Move>() { new Acidspray() },
			[20] = new List<Move>() { new Headbutt() },
			[24] = new List<Move>() { new Flail() },
			[28] = new List<Move>() { new Scaryface() },
			[32] = new List<Move>() { new Xscissor() },
			[36] = new List<Move>() { new Swordsdance() },
			[40] = new List<Move>() { new Takedown() },
			[44] = new List<Move>() { new Bugbuzz() },
			[48] = new List<Move>() { new Doubleedge() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bugbuzz(), new Drillrun(), new Encore(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Gigadrain(), new Hiddenpower(), new Irondefense(), new Megahorn(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Round(), new Scaryface(), new Screech(), new Sleeptalk(), new Snore(), new Substitute(), new Swordsdance(), new Xscissor() };
		public override List<Move> EggMoves => new List<Move>() { new Bugbite(), new Counter(), new Knockoff(), new Nightslash(), new Slash() };
		public override int Weight => 59;
		public override int ExpYield => 63;
		public override int CatchRate => 200;
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