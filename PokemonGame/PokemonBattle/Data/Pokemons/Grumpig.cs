using PokemonGame.PokemonBattle.Data.Abilities;
using PokemonGame.PokemonBattle.Data.Moves;
using PokemonGame.PokemonBattle.Entities;
using PokemonGame.PokemonBattle.Enums;
using System.Collections.Generic;

namespace PokemonGame.PokemonBattle.Data.Pokemons;

public class Grumpig : Pokemon
{
	public override string Name => "Grumpig";
	public override List<Ability> AvailableAbilities => new() {new Abilities.Thickfat(), new Abilities.Owntempo() };
	public override List<Ability> AvailableHiddenAbilities => new() {new Abilities.Gluttony() };
	public override Stats BaseStats => new Stats(80, 45, 65, 90, 110, 80);
	public override ExperienceGroup ExperienceGroup => ExperienceGroup.Fast;
	public override List<PokemonType> Types => new() {PokemonType.Psychic };
	public override Dictionary<int, List<Move>> LevelUpLearnSet => new()
	{
		[0] = new List<Move>() { new Moves.Teeterdance() },
		[1] = new List<Move>() { new Moves.Teeterdance(), new Moves.Belch(), new Moves.Splash() },
		[7] = new List<Move>() { new Moves.Confusion() },
		[10] = new List<Move>() { new Moves.Growl() },
		[14] = new List<Move>() { new Moves.Psybeam() },
		[15] = new List<Move>() { new Moves.Psychup() },
		[18] = new List<Move>() { new Moves.Confuseray() },
		[21] = new List<Move>() { new Moves.Magiccoat() },
		[26] = new List<Move>() { new Moves.Zenheadbutt() },
		[29] = new List<Move>() { new Moves.Powergem() },
		[35] = new List<Move>() { new Moves.Rest(), new Moves.Snore() },
		[42] = new List<Move>() { new Moves.Psyshock() },
		[46] = new List<Move>() { new Moves.Payback() },
		[52] = new List<Move>() { new Moves.Psychic() },
		[60] = new List<Move>() { new Moves.Bounce() },
	};
	public override List<Move> TutorMoves => new List<Move>() { new Moves.Allyswitch(), new Moves.Attract(), new Moves.Bounce(), new Moves.Brickbreak(), new Moves.Bulldoze(), new Moves.Calmmind(), new Moves.Chargebeam(), new Moves.Confide(), new Moves.Covet(), new Moves.Doubleteam(), new Moves.Drainpunch(), new Moves.Dreameater(), new Moves.Endure(), new Moves.Energyball(), new Moves.Facade(), new Moves.Firepunch(), new Moves.Flash(), new Moves.Fling(), new Moves.Focusblast(), new Moves.Focuspunch(), new Moves.Frustration(), new Moves.Gigaimpact(), new Moves.Grassknot(), new Moves.Healbell(), new Moves.Hiddenpower(), new Moves.Hyperbeam(), new Moves.Icepunch(), new Moves.Icywind(), new Moves.Irontail(), new Moves.Laserfocus(), new Moves.Lightscreen(), new Moves.Magiccoat(), new Moves.Nastyplot(), new Moves.Payback(), new Moves.Poweruppunch(), new Moves.Protect(), new Moves.Psychic(), new Moves.Psychup(), new Moves.Psyshock(), new Moves.Raindance(), new Moves.Recycle(), new Moves.Reflect(), new Moves.Rest(), new Moves.Return(), new Moves.Roleplay(), new Moves.Round(), new Moves.Shadowball(), new Moves.Shockwave(), new Moves.Signalbeam(), new Moves.Skillswap(), new Moves.Sleeptalk(), new Moves.Snatch(), new Moves.Snore(), new Moves.Substitute(), new Moves.Sunnyday(), new Moves.Swagger(), new Moves.Taunt(), new Moves.Telekinesis(), new Moves.Thief(), new Moves.Thunderpunch(), new Moves.Thunderwave(), new Moves.Torment(), new Moves.Trick(), new Moves.Trickroom(), new Moves.Zenheadbutt() };
	public override int Weight => 715;
	public override int ExpYield => 165;
	public override int CatchRate => 60;
	public override Dictionary<Stat, int> EVYield => new()
	{
		[Stat.HP] = 0,
		[Stat.Attack] = 0,
		[Stat.Defense] = 0,
		[Stat.SpecialAttack] = 0,
		[Stat.SpecialDefense] = 2,
		[Stat.Speed] = 0
	};
}