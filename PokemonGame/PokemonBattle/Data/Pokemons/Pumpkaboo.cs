using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Pumpkaboo : Pokemon
	{
		public override string Name => "Pumpkaboo";
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Frisk() };
		public override Stats BaseStats => new Stats(44, 66, 70, 56, 44, 55);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Trickortreat(), new Astonish() },
			[4] = new List<Move>() { new Shadowsneak() },
			[8] = new List<Move>() { new Confuseray() },
			[12] = new List<Move>() { new Trickortreat(), new Razorleaf() },
			[16] = new List<Move>() { new Leechseed() },
			[20] = new List<Move>() { new Bulletseed() },
			[24] = new List<Move>() { new Trickortreat(), new Scaryface() },
			[28] = new List<Move>() { new Worryseed() },
			[32] = new List<Move>() { new Seedbomb() },
			[36] = new List<Move>() { new Trickortreat(), new Shadowball() },
			[40] = new List<Move>() { new Trick() },
			[44] = new List<Move>() { new Painsplit() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Bulletseed(), new Darkpulse(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Foulplay(), new Gigadrain(), new Grassknot(), new Grassyglide(), new Gyroball(), new Hex(), new Hiddenpower(), new Imprison(), new Lightscreen(), new Mysticalfire(), new Poltergeist(), new Protect(), new Psychic(), new Rest(), new Rockslide(), new Round(), new Safeguard(), new Scaryface(), new Seedbomb(), new Shadowball(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Thief(), new Trick(), new Trickroom(), new Willowisp() };
		public override List<Move> EggMoves => new List<Move>() { new Curse(), new Destinybond(), new Disable() };
		public override int Weight => 35;
		public override int ExpYield => 67;
		public override int CatchRate => 120;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 1,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}