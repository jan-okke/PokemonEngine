using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Lunatone : Pokemon
{
	public override string Name => "Lunatone";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Levitate() };
	public override Stats BaseStats => new Stats(90, 55, 65, 95, 85, 70);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Rock, PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[1] = new List<Move>() { new Moves.Moonblast(), new Moves.Moonlight(), new Moves.Tackle(), new Moves.Harden(), new Moves.Confusion(), new Moves.Rockthrow() },
		[5] = new List<Move>() { new Moves.Hypnosis() },
		[10] = new List<Move>() { new Moves.Rockpolish() },
		[15] = new List<Move>() { new Moves.Rockslide() },
		[20] = new List<Move>() { new Moves.Psyshock() },
		[25] = new List<Move>() { new Moves.Cosmicpower() },
		[30] = new List<Move>() { new Moves.Psychic() },
		[35] = new List<Move>() { new Moves.Stoneedge() },
		[40] = new List<Move>() { new Moves.Futuresight() },
		[45] = new List<Move>() { new Moves.Magicroom() },
		[50] = new List<Move>() { new Moves.Explosion() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Acrobatics(), new Moves.Allyswitch(), new Moves.Batonpass(), new Moves.Blizzard(), new Moves.Bodyslam(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Cosmicpower(), new Moves.Doubleteam(), new Moves.Dreameater(), new Moves.Earthpower(), new Moves.Earthquake(), new Moves.Endure(), new Moves.Explosion(), new Moves.Facade(), new Moves.Flash(), new Moves.Futuresight(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Gyroball(), new Moves.Hail(), new Moves.Helpinghand(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icebeam(), new Moves.Icywind(), new Moves.Ironhead(), new Moves.Lightscreen(), new Moves.Magicroom(), new Moves.Meteorbeam(), new Moves.Nastyplot(), new Moves.Powergem(), new Moves.Powerswap(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychicterrain(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Rockblast(), new Moves.Rockpolish(), new Moves.Rockslide(), new Moves.Rocktomb(), new Moves.Round(), new Moves.Safeguard(), new Moves.Sandstorm(), new Moves.Sandtomb(), new Moves.Selfdestruct(), new Moves.Shadowball(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snore(), new Moves.Stealthrock(), new Moves.Stompingtantrum(), new Moves.Stoneedge(), new Moves.Storedpower(), new Moves.Substitute(), new Moves.Swagger(), new Moves.Swift(), new Moves.Trickroom(), new Moves.Weatherball(), new Moves.Zenheadbutt() };
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