using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Steenee : Pokemon
	{
		public override string Name => "Steenee";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Leafguard(), new Abilities.Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Sweetveil() };
		public override Stats BaseStats => new Stats(52, 40, 48, 40, 48, 62);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Flail(), new Moves.Splash(), new Moves.Playnice(), new Moves.Rapidspin(), new Moves.Razorleaf() },
			[16] = new List<Move>() { new Moves.Sweetscent() },
			[22] = new List<Move>() { new Moves.Magicalleaf() },
			[28] = new List<Move>() { new Moves.Stomp() },
			[34] = new List<Move>() { new Moves.Teeterdance() },
			[40] = new List<Move>() { new Moves.Aromaticmist() },
			[46] = new List<Move>() { new Moves.Aromatherapy() },
			[52] = new List<Move>() { new Moves.Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Attract(), new Moves.Bounce(), new Moves.Charm(), new Moves.Dazzlinggleam(), new Moves.Drainingkiss(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fling(), new Moves.Gigadrain(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Leafstorm(), new Moves.Lightscreen(), new Moves.Lowsweep(), new Moves.Magicalleaf(), new Moves.Payback(), new Moves.Playrough(), new Moves.Protect(), new Moves.Reflect(), new Moves.Rest(), new Moves.Round(), new Moves.Safeguard(), new Moves.Seedbomb(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Tripleaxel(), new Moves.Zenheadbutt() };
		public override int Weight => 82;
		public override int ExpYield => 102;
		public override int CatchRate => 120;
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