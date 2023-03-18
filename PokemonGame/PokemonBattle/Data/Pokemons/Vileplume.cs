using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Vileplume : Pokemon
	{
		public override string Name => "Vileplume";
		public override List<Ability> AvailableAbilities => new() {new Chlorophyll() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Effectspore() };
		public override Stats BaseStats => new Stats(75, 80, 85, 50, 110, 90);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[0] = new List<Move>() { new Petalblizzard() },
			[1] = new List<Move>() { new Petalblizzard(), new Aromatherapy(), new Megadrain(), new Poisonpowder(), new Stunspore(), new Sleeppowder(), new Gigadrain(), new Toxic(), new Moonblast(), new Grassyterrain(), new Moonlight(), new Petaldance(), new Absorb(), new Growth(), new Acid(), new Sweetscent() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bulletseed(), new Charm(), new Corrosivegas(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Drainpunch(), new Endure(), new Energyball(), new Facade(), new Flash(), new Fling(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Pollenpuff(), new Protect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Swagger(), new Swordsdance(), new Toxic(), new Venoshock() };
		public override int Weight => 186;
		public override int ExpYield => 245;
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