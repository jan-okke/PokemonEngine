using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Parasect : Pokemon
	{
		public override string Name => "Parasect";
		public override List<Ability> AvailableAbilities => new() {new Effectspore(), new Dryskin() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Damp() };
		public override Stats BaseStats => new Stats(60, 95, 80, 60, 80, 30);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Bug, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Crosspoison(), new Scratch(), new Stunspore(), new Poisonpowder(), new Absorb() },
			[6] = new List<Move>() { new Stunspore(), new Poisonpowder() },
			[11] = new List<Move>() { new Absorb() },
			[17] = new List<Move>() { new Furycutter() },
			[22] = new List<Move>() { new Spore() },
			[29] = new List<Move>() { new Slash() },
			[37] = new List<Move>() { new Growth() },
			[44] = new List<Move>() { new Gigadrain() },
			[51] = new List<Move>() { new Aromatherapy() },
			[59] = new List<Move>() { new Ragepowder() },
			[66] = new List<Move>() { new Xscissor() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Aerialace(), new Afteryou(), new Attract(), new Brickbreak(), new Bugbite(), new Bulletseed(), new Confide(), new Cut(), new Dig(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Falseswipe(), new Flash(), new Frustration(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Hiddenpower(), new Hyperbeam(), new Knockoff(), new Leechlife(), new Lightscreen(), new Naturepower(), new Protect(), new Rest(), new Return(), new Rocksmash(), new Round(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Strugglebug(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Synthesis(), new Thief(), new Throatchop(), new Venoshock(), new Worryseed(), new Xscissor() };
		public override int Weight => 295;
		public override int ExpYield => 142;
		public override int CatchRate => 75;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 2,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}