using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons
{
	public class Lunatone : Pokemon
	{
		public override string Name => "Lunatone";
		public override List<Ability> AvailableAbilities => new() {new Levitate() };
		public override Stats BaseStats => new Stats(90, 55, 65, 70, 95, 85);
		public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
		public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Psychic };
		public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
		{
			[1] = new List<Move>() { new Moonblast(), new Moonlight(), new Tackle(), new Harden(), new Confusion(), new Rockthrow() },
			[5] = new List<Move>() { new Hypnosis() },
			[10] = new List<Move>() { new Rockpolish() },
			[15] = new List<Move>() { new Rockslide() },
			[20] = new List<Move>() { new Psyshock() },
			[25] = new List<Move>() { new Cosmicpower() },
			[30] = new List<Move>() { new Psychic() },
			[35] = new List<Move>() { new Stoneedge() },
			[40] = new List<Move>() { new Futuresight() },
			[45] = new List<Move>() { new Magicroom() },
			[50] = new List<Move>() { new Explosion() },
		};
		public override List<Move> TutorMoves => new List<Move>() { new Acrobatics(), new Allyswitch(), new Batonpass(), new Blizzard(), new Bodyslam(), new Bulldoze(), new Calmmind(), new Chargebeam(), new Cosmicpower(), new Doubleteam(), new Dreameater(), new Earthpower(), new Earthquake(), new Endure(), new Explosion(), new Facade(), new Flash(), new Futuresight(), new Gigaimpact(), new Grassknot(), new Gyroball(), new Hail(), new Helpinghand(), new Hiddenpower(), new Hyperbeam(), new Icebeam(), new Icywind(), new Ironhead(), new Lightscreen(), new Magicroom(), new Meteorbeam(), new Nastyplot(), new Powergem(), new Powerswap(), new Protect(), new Psychic(), new Psychicterrain(), new Psychup(), new Psyshock(), new Raindance(), new Recycle(), new Reflect(), new Rest(), new Rockblast(), new Rockpolish(), new Rockslide(), new Rocktomb(), new Round(), new Safeguard(), new Sandstorm(), new Sandtomb(), new Selfdestruct(), new Shadowball(), new Skillswap(), new Sleeptalk(), new Snore(), new Stealthrock(), new Stompingtantrum(), new Stoneedge(), new Storedpower(), new Substitute(), new Swagger(), new Swift(), new Trickroom(), new Weatherball(), new Zenheadbutt() };
		public override int Weight => 1680;
		public override int ExpYield => 161;
		public override int CatchRate => 45;
		public override Dictionary<Stat, int> EVYield => new()
		{
			[Stat.HP] = 0,
			[Stat.Attack] = 0,
			[Stat.Defense] = 0,
			[Stat.SpecialAttack] = 2,
			[Stat.SpecialDefense] = 0,
			[Stat.Speed] = 0
		};
	}
}