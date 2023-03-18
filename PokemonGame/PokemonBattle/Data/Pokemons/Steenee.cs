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
		public override List<Ability> AvailableAbilities => new() {new Leafguard(), new Oblivious() };
		public override List<Ability> AvailableHiddenAbilities => new() {new Sweetveil() };
		public override Stats BaseStats => new Stats(52, 40, 48, 40, 48, 62);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Parabolic;
		public override List<PokemonType> Types => new() {PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Flail(), new Splash(), new Playnice(), new Rapidspin(), new Razorleaf() },
			[16] = new List<Move>() { new Sweetscent() },
			[22] = new List<Move>() { new Magicalleaf() },
			[28] = new List<Move>() { new Stomp() },
			[34] = new List<Move>() { new Teeterdance() },
			[40] = new List<Move>() { new Aromaticmist() },
			[46] = new List<Move>() { new Aromatherapy() },
			[52] = new List<Move>() { new Leafstorm() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Attract(), new Bounce(), new Charm(), new Dazzlinggleam(), new Drainingkiss(), new Endure(), new Energyball(), new Facade(), new Fling(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Helpinghand(), new Hiddenpower(), new Leafstorm(), new Lightscreen(), new Lowsweep(), new Magicalleaf(), new Payback(), new Playrough(), new Protect(), new Reflect(), new Rest(), new Round(), new Safeguard(), new Seedbomb(), new Sleeptalk(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Tripleaxel(), new Zenheadbutt() };
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