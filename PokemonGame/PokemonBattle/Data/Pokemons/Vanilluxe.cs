using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vanilluxe : Pokemon
	{
		public override string Name => "Vanilluxe";
		public override List<Ability> AvailableAbilities => new() {new Icebody(), new Snowwarning() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Weakarmor() };
		public override Stats BaseStats => new Stats(71, 95, 85, 79, 110, 95);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Slow;
		public override List<PokemonType> Types => new() {PokemonType.Ice };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Weatherball(), new Iciclecrash(), new Freezedry(), new Astonish(), new Harden(), new Taunt(), new Mist() },
			[12] = new List<Move>() { new Icywind() },
			[16] = new List<Move>() { new Avalanche() },
			[20] = new List<Move>() { new Hail() },
			[24] = new List<Move>() { new Iciclespear() },
			[28] = new List<Move>() { new Uproar() },
			[32] = new List<Move>() { new Acidarmor() },
			[38] = new List<Move>() { new Mirrorcoat() },
			[44] = new List<Move>() { new Icebeam() },
			[52] = new List<Move>() { new Blizzard() },
			[60] = new List<Move>() { new Sheercold() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Avalanche(), new Beatup(), new Blizzard(), new Endure(), new Facade(), new Flashcannon(), new Gigaimpact(), new Hail(), new Hiddenpower(), new Hyperbeam(), new Hypervoice(), new Icebeam(), new Iciclespear(), new Icywind(), new Imprison(), new Irondefense(), new Lightscreen(), new Protect(), new Raindance(), new Rest(), new Round(), new Selfdestruct(), new Sleeptalk(), new Snore(), new Substitute(), new Taunt(), new Uproar(), new Weatherball() };
		public override int Weight => 575;
		public override int ExpYield => 268;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 3,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}