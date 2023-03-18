using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Leavanny : Pokemon
	{
		public override string Name => "Leavanny";
		public override List<Ability> AvailableAbilities => new() {new Swarm(), new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Overcoat() };
		public override Stats BaseStats => new Stats(75, 103, 80, 70, 80, 92);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Slash() },
			[1] = new List<Move>() { new Slash(), new Falseswipe(), new Tackle(), new Stringshot(), new Bugbite(), new Razorleaf() },
			[8] = new List<Move>() { new Bugbite() },
			[15] = new List<Move>() { new Razorleaf() },
			[22] = new List<Move>() { new Strugglebug() },
			[29] = new List<Move>() { new Fellstinger() },
			[32] = new List<Move>() { new Helpinghand() },
			[36] = new List<Move>() { new Leafblade() },
			[39] = new List<Move>() { new Xscissor() },
			[43] = new List<Move>() { new Entrainment() },
			[46] = new List<Move>() { new Swordsdance() },
			[50] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Attract(), new Bugbite(), new Calmmind(), new Confide(), new Cut(), new Doubleteam(), new Dreameater(), new Electroweb(), new Energyball(), new Facade(), new Falseswipe(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Healbell(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Irondefense(), new Knockoff(), new Laserfocus(), new Lightscreen(), new Magiccoat(), new Naturepower(), new Payback(), new Poisonjab(), new Protect(), new Reflect(), new Rest(), new Return(), new Round(), new Safeguard(), new Seedbomb(), new Shadowclaw(), new Signalbeam(), new Sleeptalk(), new Snore(), new Solarbeam(), new Steelwing(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Throatchop(), new Toxic(), new Worryseed(), new Xscissor() };
		public override int Weight => 205;
		public override int ExpYield => 250;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 3,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}