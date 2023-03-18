using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gliscor : Pokemon
	{
		public override string Name => "Gliscor";
		public override List<Ability> AvailableAbilities => new() {new Hypercutter(), new Sandveil() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Poisonheal() };
		public override Stats BaseStats => new Stats(75, 95, 125, 95, 45, 75);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Ground, PokemonType.Flying };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Guillotine(), new Thunderfang(), new Icefang(), new Firefang(), new Poisonjab(), new Sandattack(), new Harden(), new Knockoff() },
			[4] = new List<Move>() { new Sandattack() },
			[7] = new List<Move>() { new Harden() },
			[10] = new List<Move>() { new Knockoff() },
			[13] = new List<Move>() { new Quickattack() },
			[16] = new List<Move>() { new Furycutter() },
			[19] = new List<Move>() { new Mudslap() },
			[22] = new List<Move>() { new Acrobatics() },
			[27] = new List<Move>() { new Nightslash() },
			[30] = new List<Move>() { new Uturn() },
			[35] = new List<Move>() { new Screech() },
			[40] = new List<Move>() { new Xscissor() },
			[45] = new List<Move>() { new Earthquake() },
			[50] = new List<Move>() { new Swordsdance() },
			[55] = new List<Move>() { new Guillotine() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Aerialace(), new Aquatail(), new Attract(), new Brickbreak(), new Brutalswing(), new Bugbite(), new Bulldoze(), new Confide(), new Cut(), new Darkpulse(), new Defog(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Facade(), new Falseswipe(), new Fling(), new Frustration(), new Gigaimpact(), new Hiddenpower(), new Hyperbeam(), new Irontail(), new Knockoff(), new Payback(), new Poisonjab(), new Protect(), new Raindance(), new Rest(), new Return(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Roost(), new Round(), new Sandstorm(), new Skyattack(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Stealthrock(), new Steelwing(), new Stoneedge(), new Strength(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Tailwind(), new Taunt(), new Thief(), new Throatchop(), new Torment(), new Uturn(), new Venoshock(), new Xscissor() };
		public override int Weight => 425;
		public override int ExpYield => 179;
		public override int CatchRate => 30;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}