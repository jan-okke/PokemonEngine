using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Cradily : Pokemon
	{
		public override string Name => "Cradily";
		public override List<Ability> AvailableAbilities => new() {new Suctioncups() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Stormdrain() };
		public override Stats BaseStats => new Stats(86, 81, 97, 43, 81, 107);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Erratic;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Leechseed(), new Wrap(), new Astonish(), new Acid(), new Confuseray() },
			[12] = new List<Move>() { new Ingrain() },
			[16] = new List<Move>() { new Ancientpower() },
			[20] = new List<Move>() { new Megadrain() },
			[24] = new List<Move>() { new Brine() },
			[28] = new List<Move>() { new Amnesia() },
			[32] = new List<Move>() { new Gastroacid() },
			[36] = new List<Move>() { new Gigadrain() },
			[43] = new List<Move>() { new Stockpile(), new Spitup(), new Swallow() },
			[48] = new List<Move>() { new Energyball() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Amnesia(), new Attract(), new Bodyslam(), new Brine(), new Bulldoze(), new Bulletseed(), new Dig(), new Doubleteam(), new Earthpower(), new Earthquake(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Meteorbeam(), new Mudshot(), new Powerwhip(), new Protect(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocksmash(), new Rocktomb(), new Round(), new Sandstorm(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Solarbeam(), new Stealthrock(), new Stoneedge(), new Strength(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance() };
		public override int Weight => 604;
		public override int ExpYield => 173;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 2,
			[Stat.Speed] = 0
		};
	}
}