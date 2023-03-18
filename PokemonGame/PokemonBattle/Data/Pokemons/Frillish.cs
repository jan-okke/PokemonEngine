using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Frillish : Pokemon
	{
		public override string Name => "Frillish";
		public override List<Ability> AvailableAbilities => new() {new Waterabsorb(), new Cursedbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Damp() };
		public override Stats BaseStats => new Stats(55, 40, 50, 65, 85, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Absorb(), new Watergun() },
			[4] = new List<Move>() { new Poisonsting() },
			[8] = new List<Move>() { new Nightshade() },
			[12] = new List<Move>() { new Waterpulse() },
			[16] = new List<Move>() { new Raindance() },
			[20] = new List<Move>() { new Hex() },
			[24] = new List<Move>() { new Brine() },
			[28] = new List<Move>() { new Recover() },
			[32] = new List<Move>() { new Shadowball() },
			[36] = new List<Move>() { new Whirlpool() },
			[41] = new List<Move>() { new Hydropump() },
			[44] = new List<Move>() { new Destinybond() },
			[48] = new List<Move>() { new Waterspout() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Blizzard(), new Brine(), new Darkpulse(), new Dazzlinggleam(), new Dive(), new Endure(), new Energyball(), new Facade(), new Gigadrain(), new Hail(), new Hex(), new Hiddenpower(), new Hydropump(), new Icebeam(), new Icywind(), new Imprison(), new Poltergeist(), new Protect(), new Psychic(), new Raindance(), new Rest(), new Round(), new Safeguard(), new Scald(), new Shadowball(), new Sleeptalk(), new Sludgebomb(), new Sludgewave(), new Snore(), new Substitute(), new Surf(), new Taunt(), new Trick(), new Trickroom(), new Waterfall(), new Whirlpool(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Acidarmor(), new Bubblebeam(), new Confuseray(), new Mist(), new Painsplit(), new Strengthsap() };
		public override int Weight => 330;
		public override int ExpYield => 67;
		public override int CatchRate => 190;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 1,
			[Stat.Speed] = 0
		};
	}
}