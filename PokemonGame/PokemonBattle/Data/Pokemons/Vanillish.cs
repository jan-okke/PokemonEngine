using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vanillish : Pokemon
	{
		public override string Name => "Vanillish";
		public override List<Ability> AvailableAbilities => new() {new Icebody(), new Snowcloak() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(51, 65, 65, 59, 80, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Astonish(), new Harden(), new Taunt(), new Mist() },
			[12] = new List<Move>() { new Icywind() },
			[16] = new List<Move>() { new Avalanche() },
			[20] = new List<Move>() { new Hail() },
			[24] = new List<Move>() { new Iciclespear() },
			[28] = new List<Move>() { new Uproar() },
			[32] = new List<Move>() { new Acidarmor() },
			[38] = new List<Move>() { new Mirrorcoat() },
			[44] = new List<Move>() { new Icebeam() },
			[50] = new List<Move>() { new Blizzard() },
			[56] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Avalanche(), new Blizzard(), new Endure(), new Facade(), new Flashcannon(), new Hail(), new Hiddenpower(), new Hypervoice(), new Icebeam(), new Iciclespear(), new Icywind(), new Imprison(), new Irondefense(), new Lightscreen(), new Protect(), new Raindance(), new Rest(), new Round(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Substitute(), new Taunt(), new Uproar() };
		public override int Weight => 410;
		public override int ExpYield => 138;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}