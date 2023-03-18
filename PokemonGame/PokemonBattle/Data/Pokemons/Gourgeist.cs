using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Gourgeist : Pokemon
	{
		public override string Name => "Gourgeist";
		public override List<Ability> AvailableAbilities => new() {new Abilities.Pickup(), new Abilities.Frisk() };
		public override Stats BaseStats => new Stats(55, 85, 122, 58, 75, 99);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moves.Explosion(), new Moves.Moonblast(), new Moves.Trickortreat(), new Moves.Astonish(), new Moves.Shadowsneak(), new Moves.Confuseray() },
			[12] = new List<Move>() { new Moves.Trickortreat(), new Moves.Razorleaf() },
			[16] = new List<Move>() { new Moves.Leechseed() },
			[20] = new List<Move>() { new Moves.Bulletseed() },
			[24] = new List<Move>() { new Moves.Trickortreat(), new Moves.Scaryface() },
			[28] = new List<Move>() { new Moves.Worryseed() },
			[32] = new List<Move>() { new Moves.Seedbomb() },
			[36] = new List<Move>() { new Moves.Trickortreat(), new Moves.Shadowball() },
			[40] = new List<Move>() { new Moves.Trick() },
			[44] = new List<Move>() { new Moves.Painsplit() },
			[48] = new List<Move>() { new Moves.Phantomforce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Brutalswing(), new Moves.Bulletseed(), new Moves.Darkpulse(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Fireblast(), new Moves.Flamethrower(), new Moves.Focusblast(), new Moves.Foulplay(), new Moves.Gigadrain(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Grassyglide(), new Moves.Gyroball(), new Moves.Hex(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Imprison(), new Moves.Lightscreen(), new Moves.Mysticalfire(), new Moves.Nastyplot(), new Moves.Phantomforce(), new Moves.Poltergeist(), new Moves.Powerwhip(), new Moves.Protect(), new Moves.Psychic(), new Moves.Rest(), new Moves.Rockslide(), new Moves.Round(), new Moves.Safeguard(), new Moves.Scaryface(), new Moves.Seedbomb(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Skittersmack(), new Moves.Sleeptalk(), new Moves.Sludgebomb(), new Moves.Snore(), new Moves.Solarbeam(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Thief(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Willowisp() };
		public override int Weight => 95;
		public override int ExpYield => 173;
		public override int CatchRate => 60;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 2,
			[Stat.SpecialAttack] = 0,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}