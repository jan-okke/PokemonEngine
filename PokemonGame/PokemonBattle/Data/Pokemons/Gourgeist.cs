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
		public override List<Ability> AvailableAbilities => new() {new Pickup(), new Frisk() };
		public override Stats BaseStats => new Stats(55, 85, 122, 58, 75, 99);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Medium;
		public override List<PokemonType> Types => new() {PokemonType.Ghost, PokemonType.Grass };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Explosion(), new Moonblast(), new Trickortreat(), new Astonish(), new Shadowsneak(), new Confuseray() },
			[12] = new List<Move>() { new Trickortreat(), new Razorleaf() },
			[16] = new List<Move>() { new Leechseed() },
			[20] = new List<Move>() { new Bulletseed() },
			[24] = new List<Move>() { new Trickortreat(), new Scaryface() },
			[28] = new List<Move>() { new Worryseed() },
			[32] = new List<Move>() { new Seedbomb() },
			[36] = new List<Move>() { new Trickortreat(), new Shadowball() },
			[40] = new List<Move>() { new Trick() },
			[44] = new List<Move>() { new Painsplit() },
			[48] = new List<Move>() { new Phantomforce() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Allyswitch(), new Attract(), new Brutalswing(), new Bulletseed(), new Darkpulse(), new Endure(), new Energyball(), new Facade(), new Fireblast(), new Flamethrower(), new Focusblast(), new Foulplay(), new Gigadrain(), new Gigaimpact(), new Grassknot(), new Grassyglide(), new Gyroball(), new Hex(), new Hiddenpower(), new Hyperbeam(), new Imprison(), new Lightscreen(), new Mysticalfire(), new Nastyplot(), new Phantomforce(), new Poltergeist(), new Powerwhip(), new Protect(), new Psychic(), new Rest(), new Rockslide(), new Round(), new Safeguard(), new Scaryface(), new Seedbomb(), new Shadowball(), new Skillswap(), new Skittersmack(), new Sleeptalk(), new Sludgebomb(), new Snore(), new Solarbeam(), new Substitute(), new Sunnyday(), new Thief(), new Trick(), new Trickroom(), new Willowisp() };
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