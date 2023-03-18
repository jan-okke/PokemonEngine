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
		public override List<Ability> AvailableAbilities => new() {new Abilities.Waterabsorb(), new Abilities.Cursedbody() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Damp() };
		public override Stats BaseStats => new Stats(55, 40, 50, 65, 85, 40);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Water, PokemonType.Ghost };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Absorb(), new Moves.Watergun() },
			[4] = new List<Move>() { new Moves.Poisonsting() },
			[8] = new List<Move>() { new Moves.Nightshade() },
			[12] = new List<Move>() { new Moves.Waterpulse() },
			[16] = new List<Move>() { new Moves.Raindance() },
			[20] = new List<Move>() { new Moves.Hex() },
			[24] = new List<Move>() { new Moves.Brine() },
			[28] = new List<Move>() { new Moves.Recover() },
			[32] = new List<Move>() { new Moves.Shadowball() },
			[36] = new List<Move>() { new Moves.Whirlpool() },
			[41] = new List<Move>() { new Moves.Hydropump() },
			[44] = new List<Move>() { new Moves.Destinybond() },
			[48] = new List<Move>() { new Moves.Waterspout() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Blizzard(), new Moves.Brine(), new Moves.Darkpulse(), new Moves.Dazzlinggleam(), new Moves.Dive(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Gigadrain(), new Moves.Hail(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hydropump(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Imprison(), new Moves.Poltergeist(), new Moves.Protect(), new Moves.Psychic(), new Moves.Raindance(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scald(), new Moves.Shadowball(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Sludgewave(), new Moves.Snore(), new Moves.Substitute(), new Moves.Surf(), new Moves.Taunt(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Waterfall(), new Moves.Whirlpool(), new Moves.Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Moves.Acidarmor(), new Moves.Bubblebeam(), new Moves.Confuseray(), new Moves.Mist(), new Moves.Painsplit(), new Moves.Strengthsap() };
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