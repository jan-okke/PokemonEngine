using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Roserade : Pokemon
	{
		public override string Name => "Roserade";
		public override List<Ability> AvailableAbilities => new() {new Naturalcure(), new Poisonpoint() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Technician() };
		public override Stats BaseStats => new Stats(60, 70, 65, 90, 125, 105);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass, PokemonType.Poison };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Grassyterrain(), new Poisonsting(), new Venomdrench(), new Megadrain(), new Leechseed(), new Magicalleaf(), new Toxicspikes(), new Sweetscent(), new Gigadrain(), new Synthesis(), new Toxic(), new Petalblizzard(), new Aromatherapy(), new Ingrain(), new Petaldance(), new Absorb(), new Growth(), new Stunspore(), new Worryseed() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bodyslam(), new Bulletseed(), new Cut(), new Dazzlinggleam(), new Doubleteam(), new Endure(), new Energyball(), new Facade(), new Flash(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Grassyterrain(), new Hiddenpower(), new Hyperbeam(), new Leafstorm(), new Magicalleaf(), new Pinmissile(), new Poisonjab(), new Powerwhip(), new Protect(), new Psychup(), new Raindance(), new Rest(), new Round(), new Seedbomb(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Spikes(), new Substitute(), new Sunnyday(), new Swagger(), new Swift(), new Swordsdance(), new Toxic(), new Toxicspikes(), new Uproar(), new Venomdrench(), new Venoshock(), new Weatherball() };
		public override int Weight => 145;
		public override int ExpYield => 258;
		public override int CatchRate => 75;
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