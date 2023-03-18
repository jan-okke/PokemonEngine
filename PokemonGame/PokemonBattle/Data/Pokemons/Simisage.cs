using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Simisage : Pokemon
	{
		public override string Name => "Simisage";
		public override List<Ability> AvailableAbilities => new() {new Gluttony() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overgrow() };
		public override Stats BaseStats => new Stats(75, 98, 63, 101, 98, 63);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leer(), new Lick(), new Furyswipes(), new Seedbomb() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Attract(), new Brickbreak(), new Confide(), new Covet(), new Cut(), new Doubleteam(), new Endeavor(), new Energyball(), new Facade(), new Fling(), new Focusblast(), new Focuspunch(), new Frustration(), new Gastroacid(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grasspledge(), new Gunkshot(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Knockoff(), new Lowkick(), new Lowsweep(), new Naturepower(), new Payback(), new Poweruppunch(), new Protect(), new Recycle(), new Rest(), new Return(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roleplay(), new Round(), new Seedbomb(), new Shadowclaw(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Superpower(), new Swagger(), new Synthesis(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Toxic(), new Uproar(), new Workup(), new Worryseed() };
		public override int Weight => 305;
		public override int ExpYield => 174;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 2
		};
	}
}